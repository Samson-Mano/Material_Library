using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Material_Library
{
    public partial class main_form : Form
    {

        private consistent_units_form consistentUnitsForm;
        private XmlDocument xmlDoc;

        public main_form()
        {
            InitializeComponent();

            // Call a method to load material name when the form loads
            LoadMaterialNameFromXML();
        }

        private void main_form_Load(object sender, EventArgs e)
        {

        }

        private void LoadMaterialNameFromXML()
        {
            string execPath = AppDomain.CurrentDomain.BaseDirectory; // Get the executable directory
            string xmlFilePath = Path.Combine(execPath,"mastermateriallibrary.xml"); // Path to your XML file

            try
            {
                // Load the XML document
                xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                // Get all <Name> elements under <Material>
                XmlNodeList nameNodes = xmlDoc.SelectNodes("//Material/BulkDetails/Name");

                if (nameNodes != null)
                {
                    // Populate the ComboBox with the names
                    foreach (XmlNode node in nameNodes)
                    {
                        comboBox_material.Items.Add(node.InnerText);
                    }

                    // Set the selection of combobox
                    comboBox_material.SelectedIndex = Properties.Settings.Default.mat_selected;
                    
                    // Load the consistent unit list
                    LoadConsistentUnitList();
                    comboBox_units.SelectedIndex = Properties.Settings.Default.units_selected;
                }



            }
            catch (Exception ex)
            {
                // Unable to open the master material file
                MessageBox.Show("Error Loading XML file: " +  ex.Message);
            }

        }

        private void LoadConsistentUnitList()
        {
            // Define the array of units
            string[] units = {
                                "(1) kg / m / s",
                                "(2) kg / cm / s",
                                "(3) kg / cm / ms",
                                "(4) kg / cm / μs",
                                "(5) kg / mm / ms",
                                "(6) g / cm / s",
                                "(7) g / cm / μs",
                                "(8) g / mm / s",
                                "(9) g / mm / ms",
                                "(10) ton / mm / s",
                                "(11) kg / mm / s",
                                "(12) g / cm / ms"
                            };

            // Loop through the array and add each unit to the ComboBox
            foreach (string unit in units)
            {
                comboBox_units.Items.Add(unit);
            }

            // Export format
            comboBox_expFormat.Items.Add("*.xml");
            comboBox_expFormat.Items.Add("*.txt");

            comboBox_expFormat.SelectedIndex = 0;
        }


        private void main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Modify the settings based on user action
            Properties.Settings.Default.mat_selected = comboBox_material.SelectedIndex;
            Properties.Settings.Default.units_selected = comboBox_units.SelectedIndex;

            // Save application settings
            Properties.Settings.Default.Save();
        }

        private void button_consistentunit_Click(object sender, EventArgs e)
        {
            // Open the consistent unit window
            if (consistentUnitsForm == null || consistentUnitsForm.IsDisposed)
            {
                consistentUnitsForm = new consistent_units_form();
                consistentUnitsForm.FormClosed += (s, args) => consistentUnitsForm = null; // Reset form when closed
            }

            consistentUnitsForm.Show();
            consistentUnitsForm.BringToFront(); // Bring the form to the front if it is already open
        }

        private void comboBox_material_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the material data when the material selected changes
            if (comboBox_material.SelectedItem != null)
            {
                string selectedMaterial = comboBox_material.SelectedItem.ToString();
                DisplayMaterialData(selectedMaterial);
            }
        }



        private void DisplayMaterialData(string materialName)
        {

                // Find the <Material> node with the specified name
                XmlNode materialNode = xmlDoc.SelectSingleNode($"//Material/BulkDetails[Name='{materialName}']");

                if (materialNode != null)
                {
                    StringBuilder materialData = new StringBuilder();

                    foreach (XmlNode childNode in materialNode.ChildNodes)
                    {
                        if (childNode.Name != "Name") // Skip the <Name> element
                        {
                            materialData.AppendLine($"{childNode.Name}: {childNode.InnerText}");
                        }
                    }

                    // Display the material data in the RichTextBox
                    richTextBox_materialDetails.Text = materialData.ToString();
                }
                else
                {
                    richTextBox_materialDetails.Text = "Material not found.";
                }

        }




    }
}

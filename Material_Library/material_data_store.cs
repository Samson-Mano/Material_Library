using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Material_Library
{
    public class material_data_store
    {
        public struct tabular_data_store
        {
            public double temp;
            public double data;
        }


        private string material_name = "";
        private string category = ""; // METAL, PLASTIC, OTHER etc
        private string sub_category = ""; // ABS Polymer , Gas etc

        // Mechanical Data
        // Material Density Tabular or Not
        private bool is_mass_Density_tabular = false;
        private double mass_Density = 0.00; // kg/mm³
        private List<tabular_data_store> mass_Density_tabl = new List<tabular_data_store>();

        // Youngs Modulus Tabular or Not
        private bool is_youngs_mod_tabular = false;
        private double youngs_mod = 0.00; // kPa
        private List<tabular_data_store> youngs_mod_tabl = new List<tabular_data_store>();



    }
}

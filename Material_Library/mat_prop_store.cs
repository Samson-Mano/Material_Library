using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material_Library
{
    public class mat_prop_store
    {
        public struct tabular_data_store
        {
            public double column1_data; // temperature
            public double column2_data; // temperature dependent data
        }



        // Property store
        private bool is_data_available = false; // Data available
        private bool is_singular_data_available = false; // Singular Data available
        private string data_type = ""; // Data Type
        private bool is_tabular_data_available = false; // Tabular Data available
        private string column1_data_type = ""; // Column 1 of tabular data
        private string column2_data_type = ""; // Column 2 of tabular data
        private List<tabular_data_store> data_tabl = new List<tabular_data_store>();

        public void add_data(bool _is_data_available,
            bool _is_singular_data_available)
        {

        }


        public string print_data()
        {
            string data = "";



            return data;
        }

    }
}

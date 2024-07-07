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

        private string material_name = "";
        private string category = ""; // METAL, PLASTIC, OTHER etc
        private string sub_category = ""; // ABS Polymer , Gas etc
        private string material_type = ""; // Material type Isotropic, Orthotropic


        // Mechanical Data
        // 1 Material Density
        private mat_prop_store mass_density = new mat_prop_store();

        // 2 Youngs Modulus
        private mat_prop_store youngs_mod = new mat_prop_store();

        // Poissons Ratio
        private bool is_orthomaterial = false;
        private mat_prop_store poissons_ratio = new mat_prop_store();

        private double poissons_ratio_y = 0.0; // x
        private double poissons_ratio_z = 0.0; // x


        // Strength Data
        // 1 Yields strength
        private mat_prop_store yield_strength = new mat_prop_store();

        // 2 Ultimate tensile strength
        private mat_prop_store tensile_strength = new mat_prop_store();


        // Durability Data
        private double fatigue_strength_coefficient = 0.0; // kPa
        private double fatigue_strength_exponent = 0.0; //
        private double fatigue_ductility_coefficient = 0.0; //  
        private double fatigue_ductility_exponent = 0.0; //
        private double cyclic_yield_strength = 0.0; // used in Manten
        private double cyclic_strength_coefficient = 0.0; // used in AISI_Steel_Maraging, Aluminum-2014
        private double cyclic_strainhardening_exponent = 0.0;


        // Formability Data
        private double initial_strain = 0.0; // mm/mm
        private double hardening_exponent = 0.0; //
        private double strength_coefficient = 0.0; // MPa
        private double R0 = 0.0; // R0 Anisotropy Coefficient R0
        private double R45 = 0.0; // R45 Anisotropy Coefficient R45
        private double R90 = 0.0; // R90 Anisotropy Coefficient R90

        // Non linear material (Steel-Rolled, 
        private mat_prop_store stress_strain = new mat_prop_store();
        private double work_hardening = 0.0; // work hardening
        private mat_prop_store forming_limit = new mat_prop_store();
        private double plastic_strain_ratio = 0.0; // Plastic Strain Ratio


        // Aniso sample

        // Thermal properties
        // 1 Thermal Conductivity
        private mat_prop_store thermal_conductivity = new mat_prop_store();

        // 2 Specific heat
        private mat_prop_store specific_heat = new mat_prop_store();

        // 3 Thermal Expansion Co-efficient
        private mat_prop_store thermal_expansion = new mat_prop_store();

        // 4 Dynamic Viscosity
        private mat_prop_store dynamic_viscosity = new mat_prop_store();

        // 5 Molar mass
        private double molar_mass = 0.0; // kg

        // 6 Gas constant
        private double gas_constant = 0.0; // µJ/(kg·K)


        // Other
        // 1 Speed of sound
        private double sound_speed = 0.0; // Speed of sound m/s



    }
}

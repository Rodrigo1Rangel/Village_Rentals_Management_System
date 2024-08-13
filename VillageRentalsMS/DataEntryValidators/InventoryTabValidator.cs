using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VillageRentalsMS.SystemException.InventoryManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VillageRentalsMS.SystemException
{
    internal class InventoryTabValidator
    {
        /// <summary>
        /// Validates the equipment description against a maximum length.
        /// </summary>
        /// <param name="description">Equipment's description.</param>
        public static void CheckAddEquipmentDescriptionMaxLength(string description)
        {
            if (description.Count() > 100)
            {
                throw new InvalidAddEquipmentDescriptionMaxLength();
            }
        }

        /// <summary>
        /// Sets the description as a mandatory field.
        /// </summary>
        /// <param name="description">Equipment's description.</param>
        public static void CheckAddEquipmentDescriptionNN(string description)
        {
            if (description.Count() == 0)
            {
                throw new InvalidAddEquipmentDescriptionNN();
            }
        }

        /// <summary>
        /// Validates the description size against a maximum length.
        /// </summary>
        /// <param name="description">Category's description.</param>
        public static void CheckAddCategoryDescriptionMaxLength(string description)
        {
            if (description.Count() > 100)
            {
                throw new InvalidAddCategoryDescriptionMaxLength();
            }
        }

        /// <summary>
        /// Sets the description as a mandatory field.
        /// </summary>
        /// <param name="description">Category's description.</param>
        public static void CheckAddCategoryDescriptionNN(string description)
        {
            if (description.Count() == 0)
            {
                throw new InvalidAddCategoryDescriptionNN();
            }
        }

        /// <summary>
        /// Validates the daily rental cost against a pattern.
        /// </summary>
        /// <param name="daily_rental_cost">New equipment daily rental cost.</param>
        public static void CheckAddEquipmentDailyRentalCostRegex(string daily_rental_cost)
        {
            string regex_pattern = @"^(\d+.\d+)||\d+$";

            bool isMatch = Regex.IsMatch(daily_rental_cost, regex_pattern);

            if (!isMatch)
            {
                throw new InvalidAddEquipmentDailyRentalCostRegex();
            }
        }

        /// <summary>
        /// Sets the daily rental cost as a mandatory field.
        /// </summary>
        /// <param name="daily_rental_cost">New equipment daily rental cost.</param>
        public static void CheckAddEquipmentDailyRentalCostNN(string daily_rental_cost)
        {
            if (daily_rental_cost.Count() == 0)
            {
                throw new InvalidAddEquipmentDailyRentalCostNN();
            }
        }

        /// <summary>
        /// Validates the sale price against a pattern.
        /// </summary>
        /// <param name="sale_price">Sale price.</param>
        public static void CheckSetToSaleIPriceRegex(string sale_price)
        {
            string regex_pattern = @"^(\d+.\d+)||\d+$";

            bool isMatch = Regex.IsMatch(sale_price, regex_pattern, RegexOptions.IgnoreCase);

            if (!isMatch)
            {
                throw new InvalidSetToSalePriceRegex();
            }
        }
 
        /// <summary>
        /// Sets the sales price as a mandatory field.
        /// </summary>
        /// <param name="sale_price">Equipment sale price.</param>
        public static void CheckSetToSalePriceNN(string sale_price)
        {
            if (sale_price.Count() == 0)
            {
                throw new InvalidSetToSalePriceNN();
            }
        }

        /// <summary>
        /// Validates the equipment's name against a maximum length.
        /// </summary>
        /// <param name="name">Equipment's name.</param>
        public static void CheckAddEquipmentNameMaxLength(string name)
        {
            if (name.Count() > 50)
            {
                throw new InvalidAddEquipmentNameMaxLength();
            }
        }

        /// <summary>
        /// Sets the equipment's name as a mandatory field.
        /// </summary>
        /// <param name="name">Equipment's name.</param>
        public static void CheckAddEquipmentNameNN(string name)
        {
            if (name.Count() == 0)
            {
                throw new InvalidAddEquipmentNameNN();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VillageRentalsMS.SystemException
{
    internal class CustomerTabValidator
    {
        /// <summary>
        /// Validates the phone number entry against a pattern.
        /// </summary>
        /// <param name="contact_phone">Customer's phone number.</param>
        public static void CheckPhoneNumber(string contact_phone) 
        {
            if (contact_phone.Count() != 12)
            {
                throw new InvalidPhoneContact();
            }

            string regex_pattern = @"^\d{3}.\d{3}.\d{4}$";

            bool isMatch = Regex.IsMatch(contact_phone, regex_pattern, RegexOptions.IgnoreCase);

            if (!isMatch)
            {
                throw new InvalidPhoneContact();
            }
        }

        /// <summary>
        /// Validates the first name size against a maximum length.
        /// </summary>
        /// <param name="first_name">Customer's first name.</param>
        public static void CheckFirstName(string first_name)
        {
            if (first_name.Count() > 50)
            {
                throw new InvalidFirstName();
            }
        }

        /// <summary>
        /// Validates the last name size against a maximum length.
        /// </summary>
        /// <param name="last_name">Customer's last name.</param>
        public static void CheckLastName(string last_name)
        {
            if (last_name.Count() > 50)
            {
                throw new InvalidLastName();
            }
        }

        /// <summary>
        /// Validates the note size against a maximum length.
        /// </summary>
        /// <param name="note">Note related to a customer.</param>
        public static void CheckNote(string note)
        {
            if (note.Count() > 100)
            {
                throw new InvalidNote();
            }
        }

        /// <summary>
        /// Validates the email against a pattern.
        /// </summary>
        /// <param name="email">Customer's email.</param>
        public static void CheckEmailRegex(string email)
        {
            string regex_pattern = @"^\w+@\w+.\w+(.\w+||.\w+.\w+)$";

            bool isMatch = Regex.IsMatch(email, regex_pattern, RegexOptions.IgnoreCase);

            if (!isMatch)
            {
                throw new InvalidEmailRegex();
            }
        }

        /// <summary>
        /// Validates the email against a maximum length.
        /// </summary>
        /// <param name="email">Customer's email.</param>
        public static void CheckEmailLength(string email)
        {
            if (email.Count() > 100)
            {
                throw new InvalidEmailLength();
            }
        }

        /// <summary>
        /// Sets the email as a mandatory field.
        /// </summary>
        /// <param name="first_name">Customer's email.</param>
        public static void CheckEmailNN(string email)
        {
            if (email.Count() == 0)
            {
                throw new InvalidEmailNN();
            }
        }

        /// <summary>
        /// Sets the phone contact as a mandatory field.
        /// </summary>
        /// <param name="phone_contact">Customer's phone contact.</param>
        public static void CheckPhoneNumberNN(string phone_contact)
        {
            if (phone_contact.Count() == 0)
            {
                throw new InvalidPhoneContactNN();
            }
        }

        /// <summary>
        /// Sets the last name as a mandatory field.
        /// </summary>
        /// <param name="last_name">Customer's last name.</param>
        public static void CheckLastNameNN(string last_name)
        {
            if (last_name.Count() == 0)
            {
                throw new InvalidLastNameNN();
            }
        }

        /// <summary>
        /// Sets the email as a mandatory field.
        /// </summary>
        /// <param name="email">Customer's email.</param>
        public static void CheckFirstNameNN(string email)
        {
            if (email.Count() == 0)
            {
                throw new InvalidFirstNameNN();
            }
        }
    }
}
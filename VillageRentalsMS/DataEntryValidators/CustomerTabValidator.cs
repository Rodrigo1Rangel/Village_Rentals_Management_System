using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageRentalsMS.SystemException
{
    internal class CustomerTabValidator
    {
        public static void CheckPhoneNumber(string contact_phone) 
        {
            if (contact_phone.Count() != 12)
            {
                throw new InvalidPhoneNumber();
            }

            char contact_phone0 = contact_phone[0]; // digit
            char contact_phone1 = contact_phone[1]; // digit
            char contact_phone2 = contact_phone[2]; // digit
            char contact_phone3 = contact_phone[3]; // dot
            char contact_phone4 = contact_phone[4]; // digit
            char contact_phone5 = contact_phone[5]; // digit
            char contact_phone6 = contact_phone[6]; // digit
            char contact_phone7 = contact_phone[7]; // dot
            char contact_phone8 = contact_phone[8]; // digit
            char contact_phone9 = contact_phone[9]; // digit
            char contact_phone10 = contact_phone[10]; // digit
            char contact_phone11 = contact_phone[11]; // digit

            if (!(
                Char.IsDigit(contact_phone0) &&
                Char.IsDigit(contact_phone1) &&
                Char.IsDigit(contact_phone2) &&
                contact_phone3 == '.' &&
                Char.IsDigit(contact_phone4) &&
                Char.IsDigit(contact_phone5) &&
                Char.IsDigit(contact_phone6) &&
                contact_phone7 == '.' &&
                Char.IsDigit(contact_phone8) &&
                Char.IsDigit(contact_phone9) &&
                Char.IsDigit(contact_phone10) &&
                Char.IsDigit(contact_phone11)
                ))
            {
                throw new InvalidPhoneNumber();
            }
        }

        public static void CheckFirstName(string first_name)
        {
            if (first_name.Count() > 50)
            {
                throw new InvalidFirstName();
            }
        }

        public static void CheckLastName(string first_name)
        {
            if (first_name.Count() > 50)
            {
                throw new InvalidLastName();
            }
        }

        public static void CheckNote(string note)
        {
            if (note.Count() > 100)
            {
                throw new InvalidNote();
            }
        }

        public static void CheckEmailRegex(string email)
        {
            string regex_pattern = @"^\w+@\w+.\w+(.\w+||.\w+.\w+)$";

            bool isMatch = Regex.IsMatch(email, regex_pattern, RegexOptions.IgnoreCase);

            if (!isMatch)
            {
                throw new InvalidEmailRegex();
            }

            if (email.Count() > 100)
            {
                throw new InvalidEmailRegex();
            }
        }
        public static void CheckEmailLength(string email)
        {
            if (email.Count() > 100)
            {
                throw new InvalidEmailLength();
            }
        }

        public static void CheckEmailNN(string email)
        {
            if (email.Count() == 0)
            {
                throw new InvalidEmailNN();
            }
        }

        public static void CheckPhoneNumberNN(string phone_contact)
        {
            if (phone_contact.Count() == 0)
            {
                throw new InvalidPhoneNumberNN();
            }
        }

        public static void CheckLastNameNN(string last_name)
        {
            if (last_name.Count() == 0)
            {
                throw new InvalidLastNameNN();
            }
        }

        public static void CheckFirstNameNN(string email)
        {
            if (email.Count() == 0)
            {
                throw new InvalidFirstNameNN();
            }
        }
    }
}
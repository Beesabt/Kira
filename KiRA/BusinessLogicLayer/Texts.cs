﻿namespace KiRA.BusinessLogicLayer
{
    public static class Texts
    {

        public static class DataTableNames
        {
            public static string Person
            {
                get { return "Person"; }
            }
        }

        public static class PersonProperties
        {
            public static string ID
            {
                get { return "ID"; }
            }

            public static string Password
            {
                get { return "Password"; }
            }

            public static string Email
            {
                get { return "Email"; }
            }
            public static string Name
            {
                get { return "Name"; }
            }
            public static string Gender
            {
                get { return "Gender"; }
            }
            public static string RegisterNumber
            {
                get { return "RegisterNumber"; }
            }
            public static string Company
            {
                get { return "Company"; }
            }
            public static string CostCenter
            {
                get { return "CostCenter"; }
            }
            public static string Position
            {
                get { return "Position"; }
            }

            public static string WorkingHours
            {
                get { return "WorkingHours"; }
            }
            public static string DateOfStart
            {
                get { return "DateOfStart"; }
            }
            public static string DateOfBirth
            {
                get { return "DateOfBirth"; }
            }
            public static string NumberOfChildren
            {
                get { return "NumberOfChildren"; }
            }
            public static string NumberOfDisabledChildren
            {
                get { return "NumberOfDisabledChildren"; }
            }

            public static string NumberOfNewBornBabies
            {
                get { return "NumberOfNewBornBabies"; }
            }

            public static string HealthDamage
            {
                get { return "HealthDamage"; }
            }
        }

        public static class ErrorMessages
        {

            public static string WrongEmailPassword
            {
                get
                {
                    return "E-mail or password is wrong.";
                }
            }

            public static string FieldIsEmpty
            {
                get
                {
                    return " field is empty.";
                }
            }

            public static string DefaultEmailOrPassword
            {
                get
                {
                    return "You use default e-mail or password, please change it in the Settings.\nThis message appears until you change the default login parameters.";
                }
            }

            public static string WrongOldPassword
            {
                get
                {
                   return "Old password is wrong.";
                }
            }

            public static string WrongOldEmail
            {
                get
                {
                    return "Old e-mail is wrong.";
                }
            }

            public static string NewPasswordsMismatched
            {
                get
                {
                    return "The new passwords are mismatched.";
                }
            }

            public static string NewEmailMismatched
            {
                get
                {
                    return "The new e-mails are mismatched.";
                }
            }

        }

        public static class InformationMessages
        {
            public static string PasswordChanged
            {
                get
                {
                    return "Password changed successfully.";
                }
            }

            public static string RulesOfNewPassword
            {
                get
                {
                    return "The new password must contain:\n- Capital and small letter\n- At least one number\n- Required long is 8 letters";
                }
            }

            public static string EmailChanged
            {
                get
                {
                    return "E-mail changed successfully.";
                }
            }

            public static string PersonalInformationChanged
            {
                get
                {
                    return "Personal information changed successfully.";
                }
            }
        }

            public static class Captions
        {

            public static string LoginFailed
            {
                get
                {
                    return "Login failed";
                }
            }


            public static string EmptyRequiredField
            {
                get
                {
                    return "Empty reqired field";
                }
            }

            public static string DefaultLoginParameters
            {
                get
                {
                    return "Default login parameters";
                }
            }

            public static string WrongOldValue
            {
                get
                {
                    return "Wrong old value";
                }
            }

            public static string MissmatchadPasswords
            {
                get
                {
                    return "Mismatched passwords";
                }
            }

            public static string MissmatchadEmails
            {
                get
                {
                    return "Mismatched e-mails";
                }
            }

            public static string SuccessfulChange
            {
                get
                {
                     return "Successful action";
                }
            }
        }

    }
}


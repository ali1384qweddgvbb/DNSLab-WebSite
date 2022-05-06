﻿using DNSLab.Resources;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace DNSLab.Helper.Exceptions
{
    public class ExceptionsAndNotificationLevel
    {
        public string ExceptionStr { get; set; }
        public Enums.ToastLevel Level { get; set; }
        public string NormalMessage { get; set; }
    }

    public sealed class ApplicationExceptions
    {
        private readonly IStringLocalizer<Resource> _localizer;

        public ApplicationExceptions(IStringLocalizer<Resource> localizer)
        {
            _localizer = localizer;
        }

        private static List<ExceptionsAndNotificationLevel> _Exceptions;
        public List<ExceptionsAndNotificationLevel> GetExceptions()
        {
            if (_Exceptions == null)
            {
                _Exceptions = new List<ExceptionsAndNotificationLevel>{
                    new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Username_Is_Duplicate",
                         Level = Enums.ToastLevel.Error,
                         NormalMessage = _localizer["Username_Is_Duplicate"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Email_Is_Duplicate",
                         Level = Enums.ToastLevel.Error,
                         NormalMessage = _localizer["Email_Is_Duplicate"] 
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Mobile_Is_Duplicate",
                         Level = Enums.ToastLevel.Error,
                         NormalMessage = _localizer["Mobile_Is_Duplicate"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "User_Not_Found",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["User_Not_Found"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Email_Is_Not_Valid",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["Email_Is_Not_Valid"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Username_Is_Not_Valid",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["Username_Is_Not_Valid"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Username_Or_Password_Is_Wrong",
                         Level = Enums.ToastLevel.Error,
                         NormalMessage = _localizer["Username_Or_Password_Is_Wrong"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "HostName_Is_Duplicate",
                         Level = Enums.ToastLevel.Error,
                         NormalMessage = _localizer["HostName_Is_Duplicate"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "HostName_Is_Not_Valid",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["HostName_Is_Not_Valid"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "IPv4Address_Is_Not_Valid",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["IPv4Address_Is_Not_Valid"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "IPv6Address_Is_Not_Valid",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["IPv6Address_Is_Not_Valid"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "HostNameAlias_Is_Not_Valid",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["HostNameAlias_Is_Not_Valid"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Token_Not_Found_Exception",
                         Level = Enums.ToastLevel.Error,
                         NormalMessage = _localizer["Token_Not_Found_Exception"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Token_Expired_Exception",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["Token_Expired_Exception"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Token_Used_Before_Exception",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["Token_Used_Before_Exception"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "TokenName_Is_Not_Valid",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["TokenName_Is_Not_Valid"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "No_HostName_Selected",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["No_HostName_Selected"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Password_Less_Than_8_Character",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["Password_Less_Than_8_Character"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Comment_Not_Found",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["Comment_Not_Found"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Comment_Text_Is_Empty",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["Comment_Text_Is_Empty"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Mobile_Is_Not_Valid",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["Mobile_Is_Not_Valid"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Old_Password_Is_Wrong",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["Old_Password_Is_Wrong"]
                    },new ExceptionsAndNotificationLevel()
                    {
                         ExceptionStr = "Can_Not_Use_Private_Network_IP_Addresses",
                         Level = Enums.ToastLevel.Warning,
                         NormalMessage = _localizer["Can_Not_Use_Private_Network_IP_Addresses"]
                    }
                };
            }
            return _Exceptions;
        }

    }
}

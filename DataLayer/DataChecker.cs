﻿using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class DataChecker
    {
        public static bool CheckLocation(LocationModel location)
        {
            if (location == null)
            {
                return false;
            }

            if (location.Latitude != null && location.Longitude != null && location.Hash != null)
            {
                return true;
            }

            return false;
        }

        public static bool CheckAuthentication(PhoneAuthenticationModel credentials)
        {
            if (credentials == null)
            {
                return false;
            }

            if (credentials.IMEI != null && credentials.SecToken != null)
            {
                return true;
            }

            return false;
        }

        public static bool CheckCalls(CallHistoryModel callHistory)
        {
            if(callHistory == null)
            {
                return false;
            }

            if (callHistory.Calls != null && callHistory.Hash != null)
            {
                return true;
            }

            return false;
        }

        public static bool CheckContacts(ContactsModel contacts)
        {
            if (contacts == null)
            {
                return false;
            }

            if (contacts.ContactList != null && contacts.Hash != null)
            {
                return true;
            }

            return false;
        }

        public static bool CheckMessages(MessagesModel messages)
        {
            if (messages == null)
            {
                return false;
            }

            if (messages.Messages != null && messages.Hash != null)
            {
                return true;
            }

            return false;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using General_Desktop_Application.Classes;
using General_Desktop_Application.DataLayer;
using General_Desktop_Application.EF;

namespace General_Desktop_Application.BusinessLayer
{
    public static class BPreference
    {
        public static preference FindByUUID(Guid objUUID)
        {
            try
            {
                using (ModelContext objContext = new ModelContext())
                {
                    return objContext.preferences.Where(p => p.user_uuid__uniqueidentifier == objUUID).FirstOrDefault();
                }
            }
            catch { }

            return null;
        }
    }
}
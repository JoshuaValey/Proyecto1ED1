﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1ED1.Models.Model;

namespace Proyecto1ED1.Helpers
{
    public class Storage
    {
        private static Storage _instance = null;
        public static Storage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Storage();

                return _instance;
            }
        }

        public Hospital hospitalCapital = new Hospital("Hospital Capital");
        public Hospital hospitalQuetzaltenango = new Hospital("Hospital Quetzaltenango");
        public Hospital hospitalPeten = new Hospital("Hospital Peten");
        public Hospital hospitalEscuintla = new Hospital("Hospital Escuintla");
        public Hospital hospitalOriente = new Hospital("Hospital Oriente");
    }
}
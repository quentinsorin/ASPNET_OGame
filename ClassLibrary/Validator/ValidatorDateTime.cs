﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Validator
{
    class ValidatorDateTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result = true;
            DateTime dateTime;

            if (DateTime.TryParse(value.ToString(), out dateTime))
            {
                if (DateTime.Compare(dateTime, DateTime.Now) > -1)
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}

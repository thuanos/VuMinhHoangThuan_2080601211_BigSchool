﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace VuMinhHoangThuan_2080601211.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isVaild = DateTime.TryParseExact(Convert.ToString(value),
                "dd/M/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return (isVaild && dateTime > DateTime.Now);
        }
    }
}
﻿namespace CameraBazaar.Common.Validation
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

    [AttributeUsage(AttributeTargets.Property)]
    public class ValidCameraModelAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string model = value as string;

            string pattern = @"^[A-Z0-9-]+$";
            Regex rgx = new Regex(pattern);

            if (model is null || !rgx.IsMatch(model))
            {
                return false;
            }

            return true;
        }
    }
}

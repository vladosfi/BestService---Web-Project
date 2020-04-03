﻿namespace BestService.Web.ViewModels.Companies
{
    using System.Collections.Generic;
    using System.Net;
    using System.Text.RegularExpressions;

    using BestService.Common;
    using BestService.Data.Models;
    using BestService.Services.Mapping;

    public class CompaniesDetailsViewModel : IMapFrom<Company>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Rating { get; set; }

        public string LogoImage { get; set; }

        public string LogoImagePath => GlobalConstants.CloudinaryUploadDir + this.LogoImage;

        public string Description { get; set; }

        public string ShortDescription
        {
            get
            {
                string description = WebUtility.HtmlDecode(Regex.Replace(this.Description, @"<[^>]*>", string.Empty));
                return description?.Length > 150 ? description.Substring(0, 150) + "..." : description;
            }
        }

        public string UserUsername { get; set; }

        public Category Category { get; set; }
    }
}

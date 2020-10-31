using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.Common.Models
{
    public static class AttributesConstraints
    {
        #region Product

        public const byte ProductNameMaxLength = 50;
        public const short DescriptionMaxLength = 500;
        public const string PriceMinValue = "0.0";
        public const string PriceMaxValue = "79228162514264337593543950335";

        #endregion

        #region ProductImage
        public const byte ProductImageNameMaxLength = 10;
        #endregion

        #region ProductCategory

        public const byte ProductCategoryTitleMaxLength = 100;

        public const short ProductCategoryDescMaxLength = 500;

        #endregion

        #region ProductComment

        public const byte ProductCommentUserFullNameMaxLength = 200;

        public const byte PhoneNumberMaxLength = 10;

        public const byte EmailMaxLength = 253;

        public const short ContentMaxLength = 500;

        #endregion

        #region ProductRevie

        public const double ProductReviewMinRate = 0.0;
        public const double ProductReviewMaxRate = double.MaxValue;
        public const short ProductReviewContentMaxLength = 500;
        public const byte ProductReviewUserFullNameMaxLength = 200;
        public const byte ProductReviewPhoneMaxLength = 10;
        public const short ProductReviewEmailMaxLength = 253;

        #endregion

        #region Order

        public const byte OrderFirstNameMaxLength = 50;
        public const byte OrderLastNameMaxLength = 50;
        public const short OrderEmailMaxLength = 253;
        public const byte OrderPhoneMaxLength = 10;
        public const byte OrderAddressMaxLength = 100;
        public const byte OrderCountryMaxLength = 50;
        public const byte OrderCityMaxLength = 100;
        public const byte OrderZipCodeMaxLength = 32;
        public const short OrderAdditionalInformationMaxLength = 500;
        #endregion

        #region User

        public const byte UserNameMaxLength = 50;
        #endregion

        #region Country, State, City
        public const byte CountryNameMaxLength = 50;
        public const byte StateNameMaxLength = 50;
        public const byte CityNameMaxLength = 50;
        #endregion

    }
}

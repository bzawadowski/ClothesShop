namespace ClothesShop.ConstValues
{
    public struct DBValues
    {
        #region TableNames
        public const string tableAddress = "Address";
        public const string tableAvailableProducts = "AvailableProduct";
        public const string tableOrder = "Order";
        public const string tableProduct = "Product";
        public const string tableProductMark = "Mark";
        public const string tableProductOpinion = "ProductOpinion";
        public const string tableProductType = "ProductType";
        public const string tableShop = "Shop";
        public const string tableSize = "Size";
        public const string tableUser = "User";
        public const string tableProductOrders = "ProductOrders";
        public const string tableUserSession = "UserSession";
        #endregion

        #region ColumnNames
        public const string columnAddressKey = "AddressId";
        public const string columnCity = "City";
        public const string columnProvince = "Province";
        public const string columnCounty = "County";
        public const string columnCommunity = "Community";

        public const string columnAvailableProductKey = "AvailableProductId";
        public const string columnInStock = "InStockNumber";

        public const string columnOrderKey = "OrderId";
        public const string columnCreatedDate = "CreatedDate";
        public const string columnExecutedDate = "ExecutedDate";
        public const string columnIsPaid = "IsOrderPaid";
        public const string columnIsSent = "IsOrderPackageSent";
        public const string columnIsDelivered = "IsOrderDelivered";

        public const string columnProductKey = "ProductId";
        public const string columnProductName = "ProductName";
        public const string columnProductPrice = "Price";
        public const string columnImage = "Image";
        public const string columnDescription = "Description";
        public const string columnIsItInStock = "IsItInStock";
        public const string columnDiscount = "Discount";
        public const string columnGender = "Gender";
        public const string columnColor = "Color";

        public const string columnMarkKey = "MarkId";
        public const string columnMark = "Mark";
        public const string columnIsPopular = "IsPopular";
        public const string columnIsPromoted = "IsPromoted";

        public const string columnOpinionKey = "OpinionId";
        public const string columnRate = "Rate";
        public const string columnComment = "Comment";

        public const string columnTypeKey = "TypeId";
        public const string columnType = "Type";

        public const string columnShopKey = "ShopId";
        public const string columnAddress = "Address";

        public const string columnSizeKey = "SizeId";
        public const string columnSize = "Size";
        public const string columnMinValue = "MinValue";
        public const string columnMaxValue = "MaxValue";

        public const string columnUserKey = "UserId";

        public const string columnSessionKey = "SessionId";
        public const string columnToken = "Token";
        public const string columnUpdatedDate = "UpdatedDate";
        public const string columnExpiredDate = "ExpiredDate";

        #endregion

        #region ValidationValues
        public const uint valRangeGeneralMin = 1;
        public const uint valRangeZero = 0;
        public const uint valRangeStock = 1000;
        public const int valRangeIntMax = Int32.MaxValue;
        public const int valDiscountRange = 99;
        public const int valGenderCount = 4;
        public const int valOpinionMax = 5;
        public const int valMaxValue = 500;
        public const string errNullOrEmpty = "{0} is required, it cannot be empty";
        public const string errMaxLength = "{0} length cannot be longer than {1} characters";
        public const string errNull = "{0} cannot be null";
        #endregion
    }
}

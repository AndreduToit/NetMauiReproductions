namespace FontAwesome
{
    public enum EnumFontAwsomeStyle
    {
        Regular = 1 << 0,
        Solid = 1 << 1,
        Brands = 1 << 2,
        RegularSolid = Regular | Solid,
        RegularBrands = Regular | Brands,
        SolidBrands = Solid | Brands,
        RegularSolidBrands = Regular | Solid | Brands
    }
}
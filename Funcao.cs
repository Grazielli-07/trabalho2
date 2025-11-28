static class Ajustar
{
    public static decimal AjustarLatitude(decimal lat)
    {
        if (lat > 90)
            return -90 + (lat - 90);
        if (lat < -90)
            return 90 - (-90 - lat);
        return lat;
    }

    public static decimal AjustarLongitude(decimal lon)
    {
        if (lon > 180)
            return -180 + (lon - 180);
        if (lon < -180)
            return 180 - (-180 - lon);
        return lon;
    }
}



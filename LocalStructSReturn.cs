struct LocalizacaoStructSReturn
{
    public decimal Latitude;
    public decimal Longitude;

    public LocalizacaoStructSReturn(decimal lat, decimal lon)
    {
        Latitude = lat;
        Longitude = lon;
    }

    public void MoverNorte(decimal valor)
    {
        Latitude = AjustarLatitude(Latitude + valor);
    }

    public void MoverSul(decimal valor)
    {
        MoverNorte(-valor);
    }

    public void MoverLeste(decimal valor)
    {
        Longitude = AjustarLongitude(Longitude + valor);
    }

    public void MoverOeste(decimal valor)
    {
        MoverLeste(-valor);
    }
}

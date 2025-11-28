class LocalClasseSReturn
{
    public decimal Latitude { get; private set; }
    public decimal Longitude { get; private set; }

    public LocalClasseSReturn(decimal lat, decimal lon)
    {
        Latitude = lat;
        Longitude = lon;
    }

    public void MoverNorte(decimal valor)
    {
        Latitude = Ajustar.AjustarLatitude(Latitude + valor);
    }

    public void MoverSul(decimal valor)
    {
        MoverNorte(-valor);
    }

    public void MoverLeste(decimal valor)
    {
        Longitude = Ajustar.AjustarLongitude(Longitude + valor);
    }

    public void MoverOeste(decimal valor)
    {
        MoverLeste(-valor);
    }
}
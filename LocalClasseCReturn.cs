class LocalClasseCReturn
{
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }

    public LocalClasseCReturn(decimal lat, decimal lon)
    {
        Latitude = lat;
        Longitude = lon;
    }

    public LocalClasseCReturn MoverNorte(decimal valor)
    {
        return new LocalClasseCReturn(
            AjustarLatitude(this.Latitude + valor),
            this.Longitude
        );
    }

    public LocalClasseCReturn MoverSul(decimal valor)
    {
        return MoverNorte(-valor);
    }

    public LocalClasseCReturn MoverLeste(decimal valor)
    {
        return new LocalClasseCReturn(
            this.Latitude,
            AjustarLongitude(this.Longitude + valor)
        );
    }

    public LocalClasseCReturn MoverOeste(decimal valor)
    {
        return MoverLeste(-valor);
    }
    
}

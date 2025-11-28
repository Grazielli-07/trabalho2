struct LocalizacaoStructCReturn
{
    public decimal Latitude;
    public decimal Longitude;

    public LocalizacaoStructCReturn(decimal lat, decimal lon)
    {
        Latitude = lat;
        Longitude = lon;
    }

    public LocalizacaoStructCReturn MoverNorte(decimal valor)
    {
        return new LocalizacaoStructCReturn(
            AjustarLatitude(this.Latitude + valor),
            this.Longitude
        );
    }

    public LocalizacaoStructCReturn MoverSul(decimal valor)
    {
        return MoverNorte(-valor);
    }

    public LocalizacaoStructCReturn MoverLeste(decimal valor)
    {
        return new LocalizacaoStruct(
            this.Latitude,
            AjustarLongitude(this.Longitude + valor)
        );
    }

    public LocalizacaoStructCReturn MoverOeste(decimal valor)
    {
        return MoverLeste(-valor);
    }
}

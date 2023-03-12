public class Avion
{
    private float altura;
    private float velocidad;
    private float combustible;
    private int orientacion;

    public Avion(float altura, float velocidad, float combustible, int orientacion)
    {
        this.altura = altura;
        this.velocidad = velocidad;
        this.combustible = combustible;
        this.orientacion = orientacion;
    }

    public float Altura
    {
        get { return altura; }
    }

    public int Orientacion
    {
        get { return orientacion; }
    }
    public float Combustible
    {
        get { return combustible; }
    }

    public void Virar(int grados)
    {
        orientacion = (orientacion + grados) % 360;
        consumir_fuel(grados * 0.1);
    }

    public void Ascender(float metros)
    {
        altura = altura + metros;
        consumir_fuel(metros * 0.3);
    }

    public void Descender(float metros)
    {
        altura = altura - metros;
        if (altura < 0)
        {
            altura = 0;
        }
    }

    private void ConsumirFuel(float litros)
    {
        combustible = combustible - litros;
        if (combustible < 0)
        {
            combustible = 0;
        }
    }
}

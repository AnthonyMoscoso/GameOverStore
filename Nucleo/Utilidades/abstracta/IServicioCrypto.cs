namespace Nucleo.Utilidades.Abstracta
{
    public interface IServicioCrypto
    {
        string CrearSalt(int size);
        string Encriptar(string plainText, string passPhrase);
        string Desencriptar(string cipherText, string passPhrase);
    }
}

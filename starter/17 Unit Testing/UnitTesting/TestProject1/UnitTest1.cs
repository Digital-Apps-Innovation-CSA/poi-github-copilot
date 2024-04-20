using Microsoft.VisualStudio.TestPlatform.TestHost;
using UnitTesting;


namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]

        public void TestConcatenateFullNameAndBirthdate()
        {
            // Arrange
            string nombre = "Juan";
            string apellidoPaterno = "Perez";
            string apellidoMaterno = "Gomez";
            DateTime fechaNacimiento = new DateTime(1990, 1, 1);
            string expected = "PEGJ900101";
            var generator = new rfcgenerator();
        
            string result = generator.ConcatenateFullNameAndBirthdate(nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento);
            // Remove last 3 characters
            if (result.Length >= 3)
            {
                result = result.Substring(0, result.Length - 3);
            }
           
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
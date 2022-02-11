namespace Temperature
{
    public class Conversion
    {
        public enum ConversionMode {
            Celsius_to_Fahrenheit,
            Kelvin_to_Fahrenheit,
            Fahrenheit_to_Celsius,
            Celsius_to_Kelvin,
            Kelvin_to_Celsius,
            Fahrenheit_to_Kelvin
        }
        
        public double Convert(ConversionMode mode, double temperature) {
            double result = 0d;
            switch (mode) {
                case ConversionMode.Celsius_to_Fahrenheit:
                    result = (9d/5d * temperature) + 32d;
                    break;
                case ConversionMode.Kelvin_to_Fahrenheit:
                    result = (9d/5d * (temperature - 273d) + 32d);
                    break;
                case ConversionMode.Fahrenheit_to_Celsius:
                    result = (5d/9d * (temperature - 32d));
                    break;
                case ConversionMode.Celsius_to_Kelvin:
                    result = (temperature + 273d);
                    break;
                case ConversionMode.Kelvin_to_Celsius:
                    result = (temperature - 273d);
                    break;
                case ConversionMode.Fahrenheit_to_Kelvin:
                    result = (5d/9d * (temperature - 32d) + 273d);
                    break;
            }
            return Math.Round(result, 2);
        }

        public ConversionMode GetConversionMode(string from, string to)
        {
            ConversionMode mode = ConversionMode.Celsius_to_Fahrenheit;
            switch (from)
            {
                case "Celsius":
                    switch (to)
                    {
                        case "Fahrenheit":
                            mode = ConversionMode.Celsius_to_Fahrenheit;
                            break;
                        case "Kelvin":
                            mode = ConversionMode.Celsius_to_Kelvin;
                            break;
                    }
                    break;
                case "Fahrenheit":
                    switch (to)
                    {
                        case "Celsius":
                            mode = ConversionMode.Fahrenheit_to_Celsius;
                            break;
                        case "Kelvin":
                            mode = ConversionMode.Fahrenheit_to_Kelvin;
                            break;
                    }
                    break;
                case "Kelvin":
                    switch (to)
                    {
                        case "Celsius":
                            mode = ConversionMode.Kelvin_to_Celsius;
                            break;
                        case "Fahrenheit":
                            mode = ConversionMode.Kelvin_to_Fahrenheit;
                            break;
                    }
                    break;
            }
            return mode;
        }
    }
}
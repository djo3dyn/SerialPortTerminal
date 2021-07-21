using System;
using System.Collections.Generic;
using System.Text;

namespace NumberFromString
{
    class numberfromstring
    {
        // String To Number
        private string input_string;
        private int num_base;
        private string[] splited_string;
        private byte[] output_byte;
        private char[] output_char;

        // Number To String
        private string charCR ;
        private string charLF ;
        private string output_string;

        // Number Count ;
        private int number_count;
        
        /*================== String To Number ===================*/

        // Set Input string with base number to set number (override set number) 
        public int set_string(string _input, int _base , int _cr_lf = 0)
        {
            input_string = _input;
            num_base = _base;

            // Split by space
            if (_input != String.Empty) splited_string = input_string.Split(' ');

            // Switch CR LF
            switch(_cr_lf)
            {
                case 1: // CR
                    output_byte = new byte[splited_string.Length+1];
                    output_byte[splited_string.Length] = 13;
                    break;
                case 2: //LF
                    output_byte = new byte[splited_string.Length + 1];
                    output_byte[splited_string.Length] = 10;
                    break;
                case 3: // CR-LF
                    output_byte = new byte[splited_string.Length + 2];
                    output_byte[splited_string.Length] = 13;
                    output_byte[splited_string.Length + 1] = 10;
                    break;
                default:
                    output_byte = new byte[splited_string.Length];
                    break;
            }
            
            int num = 0;

            // Start Converting ...
            try
            {
                if (_base != 0)
                {
                    foreach (string i in splited_string)
                    {
                        output_byte[num++] = Convert.ToByte(i, _base);
                    }
                    //Override Input Number on Number to String
                    set_number_byte(output_byte);
                }
                if (_base == 0)
                {
                    output_string = _input;
                    output_char = _input.ToCharArray();
                    base_convert_to_byte(output_char);
                }
                //Return OK
                number_count = output_byte.Length;
                return 0;
            }
            catch (FormatException) // Wrong format number
            {
                return 1;
            }
            catch (OverflowException) // Value to small or big
            {
                return 2;
            }
        }
        public int set_string(string _input)
        {
            output_string = _input;
            output_char = _input.ToCharArray();
            num_base = 0;
            number_count = output_char.Length;
            return 0;
        }

        // Get Raw number Byte
        public byte[] get_number_byte()
        {
            return output_byte;
        }

        // Get Raw number char
        public char[] get_number_char()
        {
            return output_char;
        }

        // Get Count
        public int get_number_count()
        {
            return number_count;
        }

        /*================== Number To String ===================*/

        public void set_number_byte(byte[] _input_byte)
        {
            // Override 
            output_byte = _input_byte;
            base_convert_to_char(output_byte);
        }

        // base convert char to char
        private void base_convert_to_char(byte[] _input_byte)
        {
            int i = 0;
            char[] temp = new char[_input_byte.Length];
            foreach(byte b in _input_byte)
            {
                temp[i++] = Convert.ToChar(b);
            }
            output_char = temp;
        }

        public void set_number_char(char[] _input_char)
        {
            output_char = _input_char;
            base_convert_to_byte(output_char);
        }

        // base convert char to byte
        private void base_convert_to_byte(char[] _input_char)
        {
            int i = 0;
            byte[] temp = new byte[_input_char.Length];
            foreach (char c in _input_char)
            {
                temp[i++] = Convert.ToByte(c);
            }
            output_byte = temp;
        }

        // Base converter from number to String with sparator 
        private void base_convert_to_str(int _base)
        {
            //convert to byte
            bool _first = true;
            output_string = String.Empty;
            if (output_char.Length != 0)
            {
                try
                {
                    foreach (char c in output_char)
                    {
                        if (_first)
                        {
                            output_string += Convert.ToString(c, _base);
                            _first = false;
                        }
                        else output_string += " " + Convert.ToString(c, _base);
                    } 
                }
                catch (ArgumentException)
                {
                    output_string = "Error!";
                }
            }
        }

        // CR-LF Handle
        public void replace_CR_LF(string _charCR , string _charLF )
        {
            charCR = _charCR;
            charLF = _charLF;

            Console.WriteLine("CR LF Set..");
        }

        public void reset_CR_LF()
        {
            charCR = String.Empty;
            charLF = String.Empty;

            Console.WriteLine("CR LF ReSet..");
        }

        // Base convert to str from number
        private void base_convert_num_str()
        {
            // CR-LF Handle
            string temp = new string(output_char);
            if (charCR != String.Empty || charLF != String.Empty)
            {
                output_string = temp.Replace("\r", charCR).Replace("\n", charLF).Replace("\u000b", charLF).Replace("\u000c", charLF).Replace("\u000e", charLF).Replace("\u000f", charLF);
                Console.WriteLine("CRLF Replace");
            }
            else
            {
                output_string = temp;
            }
 
        }

        public string get_string()
        {
             base_convert_num_str();
             return output_string;
           
        }
        public string get_string_dec()
        {
            base_convert_to_str(10);
            return output_string;
        }

        public string get_string_hex()
        {
            base_convert_to_str(16);
            return output_string;
        }

        public string get_string_bin()
        {
            base_convert_to_str(2);
            return output_string;
        }

        public string get_string_base(int _base)
        {
            base_convert_to_str(_base);
            return output_string;
        }
    }
}

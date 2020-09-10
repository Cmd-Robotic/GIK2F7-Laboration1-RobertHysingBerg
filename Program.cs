using System;

namespace Laboration1
{
    class Program
    {
        static void Main(string[] args)
        {   ///I might've skipped commenting for most of the main program, oh well I suppose that's fine for now...
            mainUI();
        }
        static void mainUI()
        {   ///Main user interface segment where our prospective shaper selects a shape
            bool loopin = true;
            string rawInput;
            int input;
            bool parsed;

            Console.WriteLine("Hello and welcome to the shapezone!");

            while (loopin)
            {
                Console.WriteLine("What shape would you like to use today, shaper?");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("10. Exit program");
                rawInput = Console.ReadLine();
                
                parsed = Int32.TryParse(rawInput, out input);

                if (parsed && input != 10)
                {
                    shapeSelect(input);
                }
                else if (parsed && input == 10)
                {
                    loopin = false;
                    Console.WriteLine("Allright, press enter when you're ready to exit the program. See you around shaper!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Couldn't quite catch what you said, try again!");
                }
            }
        }
        static void shapeSelect(int userChoice)
        {   ///This segment only shoves the program along to the correct shape
            switch (userChoice)
            {
                case 1:
                    circleShaper();
                    break;
                case 2:
                    rectangleShaper();
                    break;
                case 3:
                    triangleShaper();
                    break;
                default:
                    Console.WriteLine("Sorry shaper, I don't know what shape you're trying to use, try again!");
                    break;
            }
        }
        static void circleShaper()
        {   ///Constructs a new Circle
            Circle shape = new Circle();
            Console.WriteLine("Allright, a circle has been randomly generated.");
            shapersInfo(shape);
        }
        static void rectangleShaper()
        {   ///Constructs a new Rectangle
            Rectangle shape = new Rectangle();
            Console.WriteLine("Allright, a rectangle has been randomly generated.");
            shapersInfo(shape);
        }
        static void triangleShaper()
        {   ///Constructs a new Triangle
            Triangle shape = new Triangle();
            Console.WriteLine("Allright, a triangle has been randomly generated.");
            shapersInfo(shape);
        }
        static void shapersInfo(Circle shape)
        {   ///This is where the user gets some info about the shape, I almost went ahead and made it so the user can modify the shapes but uh, that's out of scope of this lab if I've understood it correctly
            ///There are three different functions, two of them being overload functions, one for each shape and they look mostly the same with some minor differences in the Console.WriteLine()s
            bool loopin = true;
            bool parsed;
            string rawInput;
            int input;
            string question = "So what do you want to know about the shape?";

            while (loopin)
            {
                Console.WriteLine(question);
                question = "Anything else you want to know about the shape?";
                Console.WriteLine("1. Get all the info about it");
                Console.WriteLine("2. Get its area");
                Console.WriteLine("3. Get its circumference");
                Console.WriteLine("10. Go back to shape select");
                rawInput = Console.ReadLine();

                parsed = Int32.TryParse(rawInput, out input);

                if (parsed && input != 10)
                {
                    switch (input)
                    {
                        case 1:
                            (string, float[], float[]) shapeInfo = shape.getInfo();
                            Console.WriteLine("This is a {0} with a radius of {1} and a diameter of {2}. The area of this circle is around {3} and the circumference is {4}.", 
                            shapeInfo.Item1, shapeInfo.Item2[0], shapeInfo.Item2[1], shapeInfo.Item3[0], shapeInfo.Item3[1]);
                            break;
                        case 2:
                            Console.WriteLine("This circle has an area of {0}", shape.getArea());
                            break;
                        case 3:
                            Console.WriteLine("This circle has a circumference of {0}", shape.getCircumference());
                            break;
                        default:
                            Console.WriteLine("What was that input shaper? I don't think it was an option... please try again.");
                            break;
                    }
                }
                else if (parsed && input == 10)
                {
                    loopin = false;
                    Console.WriteLine("Allright, press enter when you're ready to go back to shape select shaper.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Couldn't quite catch what you said, try again!");
                }
            }
        }
        static void shapersInfo(Rectangle shape)
        {   ///This is where the user gets some info about the shape, I almost went ahead and made it so the user can modify the shapes but uh, that's out of scope of this lab if I've understood it correctly
            ///There are three different functions, two of them being overload functions, one for each shape and they look mostly the same with some minor differences in the Console.WriteLine()s
            bool loopin = true;
            bool parsed;
            string rawInput;
            int input;
            string question = "So what do you want to know about the shape?";

            while (loopin)
            {
                Console.WriteLine(question);
                question = "Anything else you want to know about the shape?";
                Console.WriteLine("1. Get all the info about it");
                Console.WriteLine("2. Get its area");
                Console.WriteLine("3. Get its circumference");
                Console.WriteLine("10. Go back to shape select");
                rawInput = Console.ReadLine();

                parsed = Int32.TryParse(rawInput, out input);

                if (parsed && input != 10)
                {
                    switch (input)
                    {
                        case 1:
                            (string, float[], float[]) shapeInfo = shape.getInfo();
                            Console.WriteLine("This is a {0} with the length of the sides being {1}, {2}, {3} and {4}. The area of this rectangle is around {5} and the circumference is {6}.", 
                            shapeInfo.Item1, shapeInfo.Item2[0], shapeInfo.Item2[1], shapeInfo.Item2[2], shapeInfo.Item2[3], shapeInfo.Item3[0], shapeInfo.Item3[1]);
                            break;
                        case 2:
                            Console.WriteLine("This rectangle has an area of {0}", shape.getArea());
                            break;
                        case 3:
                            Console.WriteLine("This rectangle has a circumference of {0}", shape.getCircumference());
                            break;
                        default:
                            Console.WriteLine("What was that input shaper? I don't think it was an option... please try again.");
                            break;
                    }
                }
                else if (parsed && input == 10)
                {
                    loopin = false;
                    Console.WriteLine("Allright, press enter when you're ready to go back to shape select shaper.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Couldn't quite catch what you said, try again!");
                }
            }
        }
        static void shapersInfo(Triangle shape)
        {   ///This is where the user gets some info about the shape, I almost went ahead and made it so the user can modify the shapes but uh, that's out of scope of this lab if I've understood it correctly
            ///There are three different functions, two of them being overload functions, one for each shape and they look mostly the same with some minor differences in the Console.WriteLine()s
            bool loopin = true;
            bool parsed;
            string rawInput;
            int input;
            string question = "So what do you want to know about the shape?";

            while (loopin)
            {
                Console.WriteLine(question);
                question = "Anything else you want to know about the shape?";
                Console.WriteLine("1. Get all the info about it");
                Console.WriteLine("2. Get its area");
                Console.WriteLine("3. Get its circumference");
                Console.WriteLine("10. Go back to shape select");
                rawInput = Console.ReadLine();

                parsed = Int32.TryParse(rawInput, out input);

                if (parsed && input != 10)
                {
                    switch (input)
                    {
                        case 1:
                            (string, float[], float[]) shapeInfo = shape.getInfo();
                            Console.WriteLine("This is a {0} with each side being {1}, {2} and {3} long respectively. The area of this triangle is around {4} and the circumference is {5}.", 
                            shapeInfo.Item1, shapeInfo.Item2[0], shapeInfo.Item2[1], shapeInfo.Item2[2], shapeInfo.Item3[0], shapeInfo.Item3[1]);
                            break;
                        case 2:
                            Console.WriteLine("This triangle has an area of {0}", shape.getArea());
                            break;
                        case 3:
                            Console.WriteLine("This triangle has a circumference of {0}", shape.getCircumference());
                            break;
                        default:
                            Console.WriteLine("What was that input shaper? I don't think it was an option... please try again.");
                            break;
                    }
                }
                else if (parsed && input == 10)
                {
                    loopin = false;
                    Console.WriteLine("Allright, press enter when you're ready to go back to shape select shaper.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Couldn't quite catch what you said, try again!");
                }
            }
        }
    }
}

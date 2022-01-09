using System;

namespace C_Sharp_Lab4
{
    public class Sweets
    {
        public int weight = 0;

        public virtual String GetInfo()
        {
            var str = String.Format("\nВес: {0}г", this.weight);
            return str;
        }

        public virtual String GetNext()
        {
            var str = "";
            return str;
        }

        public virtual String Image()
        {
            var str = "";
            return str;
        }

        public static Random rnd = new Random();
    }

    public enum ChockType { black, milk }; // тип (тёмный/молочный)

    public class Chocolate : Sweets
    {
        public string chockFill = "";
        public int chockAmount = 0;
        public ChockType ctype = ChockType.black;

        public override String GetInfo()
        {
            var str = "Тип: Шоколад";
            str += base.GetInfo();
            str += String.Format("\nНачинка: {0}", this.chockFill);
            str += String.Format("\nКол-во плиток: {0}", this.chockAmount);
            if (this.ctype == ChockType.black)
            {
                str += String.Format("\nВид: Тёмный шоколад");
            }
            else
            {
                str += String.Format("\nВид: Молочный шоколад");
            }
            return str;
        }

        public override String GetNext()
        {
            string str = "Следующее: ";
            if (this.ctype == ChockType.black)
            {
                str += String.Format("Тёмный шоколад");
            }
            else
            {
                str += String.Format("Молочный шоколад");
            }
            return str;
        }

        public override String Image()
        {
            string str = GetNext();
            str += this.chockFill;
            return str;
        }

        public static Chocolate Generate()
        {
            string[] fill = new string[3] { "Орехи", "Изюм", "Печенье" };
            return new Chocolate
            {
                weight = rnd.Next(100, 500),
                chockFill = fill[rnd.Next(0, 3)],
                chockAmount = 3 + rnd.Next(0, 9),
                ctype = (ChockType)rnd.Next(0, 2)
            };
        }
    }

    public enum BackeryType { bun, pie, cake }; // тип (bun - булочка, pie - пирожок, cake - ватрушка)

    public class Backery : Sweets
    {
        public BackeryType btype = BackeryType.bun;
        public int kcal = 0;

        public override String GetInfo()
        {
            var str = "Тип: Выпечка";
            str += base.GetInfo();
            if (this.btype == BackeryType.bun)
            {
                str += String.Format("\nВид: Булочка");
            }
            else
            {
                if (this.btype == BackeryType.pie)
                {
                    str += String.Format("\nВид: Пирожок");
                }
                else
                {
                    str += String.Format("\nВид: Ватрушка");
                }
            }
            str += String.Format("\nКкал: {0}", this.kcal);
            return str;
        }

        public override String GetNext()
        {
            string str = "Следующее: ";
            if (this.btype == BackeryType.bun)
            {
                str += String.Format("Булочка");
            }
            else
            {
                if (this.btype == BackeryType.pie)
                {
                    str += String.Format("Пирожок");
                }
                else
                {
                    str += String.Format("Ватрушка");
                }
            }
            return str;
        }

        public override String Image()
        {
            string str = GetNext();
            //str += this.btype;
            return str;
        }

        public static Backery Generate()
        {
            return new Backery
            {
                weight = rnd.Next(100, 500),
                btype = (BackeryType)rnd.Next(0, 3),
                kcal = rnd.Next(100, 500)
            };
        }
    }

    public enum FruitsType { mango, kiwi, pineapple } // тип(манго, киви, ананас)

    public class Fruits : Sweets
    {
        public FruitsType ftype = FruitsType.mango;
        public int ripeness = 0;

        public override String GetInfo()
        {
            var str = "Тип: Фрукт";
            str += base.GetInfo();
            if (this.ftype == FruitsType.mango)
            {
                str += String.Format("\nВид: Манго");
            }
            else
            {
                if (this.ftype == FruitsType.kiwi)
                {
                    str += String.Format("\nВид: Киви");
                }
                else
                {
                    str += String.Format("\nВид: Ананас");
                }
            }
            str += String.Format("\nСпелость: {0}", this.ripeness);
            return str;
        }

        public override String GetNext()
        {
            string str = "Следующее: ";
            if (this.ftype == FruitsType.mango)
            {
                str += String.Format("Манго");
            }
            else
            {
                if (this.ftype == FruitsType.kiwi)
                {
                    str += String.Format("Киви");
                }
                else
                {
                    str += String.Format("Ананас");
                }
            }
            return str;
        }

        public override String Image()
        {
            string str = GetNext();
            //str += this.ftype;
            return str;
        }

        public static Fruits Generate()
        {
            return new Fruits
            {
                weight = rnd.Next(100, 500),
                ftype = (FruitsType)rnd.Next(0, 3),
                ripeness = rnd.Next(0, 100)
            };
        }
    }
}

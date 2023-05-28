namespace Umwandlung_DAHRS.Models
{
    public class DAHRS
    {
        public static int d { set; get; }
        public static int a { set; get; }
        public static int h { set; get; }
        public static int r { set; get; }
        public static int s { set; get; }
        public static int rest { set; get; }

        public static void Umwandlung(Betrag b)
        {

            d = b.betrag / 8000;
            rest = b.betrag % 8000;

            r = rest / 6400;
            rest = rest % 6400;

            a = rest / 727;
            rest = rest % 727;

            h = rest / 145;
            rest = rest % 145;

            s = rest / 13;
            rest = rest % 13;
        }
    }
}

    


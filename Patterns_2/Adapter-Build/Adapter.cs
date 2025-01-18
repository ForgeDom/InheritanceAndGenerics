namespace Patterns_2.Adapter
{
    public enum FigureForm
    {
        Round,
        Cubed
    }
    public interface IFormChanger
    {
        string CubedToRound(FigureForm form);
        string RoundToCubed(FigureForm form);
    }

    public interface IFigure
    {
        void ApplyColor();
    }
    public interface IColor
    {
        void Paint();
    }

    public class CubedFigure : IFigure
    {
        private readonly IColor _color;

        public CubedFigure(IColor color)
        {
            _color = color;
        }

        public void ApplyColor()
        {
            Console.WriteLine("Cubed figure is being painted.");
            _color.Paint();
        }
    }

    public class RedColor : IColor
    {
        public void Paint()
        {
            Console.WriteLine("Painting with red color.");
        }
    }

    public class BlueColor : IColor
    {
        public void Paint()
        {
            Console.WriteLine("Painting with blue color.");
        }
    }

    public class RoundFigure : IFigure
    {
        public readonly IColor _color;

        public RoundFigure(IColor color)
        {
            _color = color;
        }

        public void ApplyColor()
        {
            Console.WriteLine("Round figure is being painted.");
            _color.Paint();
        }
    }
    public class CurrentFigureForm
    {
        public string Form { get; set; }
    }

    public class Adapter : IFormChanger
    {
        private readonly CurrentFigureForm _adaptee;

        public Adapter(CurrentFigureForm adaptee)
        {
            this._adaptee = adaptee;
        }

        public string CubedToRound(FigureForm form)
        {
            if (form == FigureForm.Cubed)
            {
                _adaptee.Form = "Cubed";
                return "Converted Cubed to Round";
            }
            return "No conversion needed";
        }

        public string RoundToCubed(FigureForm form)
        {
            if (form == FigureForm.Round)
            {
                _adaptee.Form = "Round";
                return "Converted Round to Cubed";
            }
            return "No conversion needed";
        }
    }
}


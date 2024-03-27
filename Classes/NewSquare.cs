
namespace BeginnersQuestionsExamples.Classes;

class NewSquare : Shape
{
    private int _side;

    public NewSquare(int n) => _side = n;

    public override int GetArea() => _side * _side;
}
// explicit operator
class Celzijus{
    private float stepeni;
    
    public float Stepeni{
        get{ return stepeni;}
    }

    public Celzijus(float temp){
        stepeni = temp;
    }
    public static explicit operator Farenhajt(Celzijus c){
        return new Farenhajt((9.0f/5.0f)*c.stepeni+32);
    }
}
class Farenhajt{
    private float stepeni;
    
    public float Stepeni{
        get{ return stepeni;}
    }
    public Farenhajt(float temp){
        stepeni = temp;
    }
    public static explicit operator Celzijus(Farenhajt fahr){
        return new Celzijus((5.0f/9.0f)*(fahr.stepeni - 32));
    }
}
class Program{
    static void Main(String[] args){
        
        Farenhajt fahr = new Farenhajt(100.0f);
        Console.Write("{0} Faranhajt",fahr.Stepeni);
        Celzijus c = (Celzijus)fahr;

        Console.Write(" = {0} Clezius",c.Stepeni);
        Farenhajt fahr2 = (Farenhajt)c;
        Console.WriteLine(" = {0} Farenhajt",fahr2.Stepeni);
    }
}
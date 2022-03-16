using System;
class GM1{
public void Wealth(){
Console.WriteLine("Method from GrandMother");
Console.WriteLine("All my wealth is yours");
}
}
class M1:GM1
{
public virtual void Health(){

Console.WriteLine("Method from Mother class");
Console.WriteLine("good healith is my strength");
}
}
class Child:M1{
public override void Health(){
Console.WriteLine("I am a fitness Freak");
}
}
class Inherit1{
public static void Main()
{
Child cobj= new Child();
cobj.Health();
cobj.Wealth();
}
}
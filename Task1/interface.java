interface Area{
    void area(); 
}
class Rectangle implements Area{
    public void area(){
        System.out.println("calculate area of rectangle");
    }
}
class Circle implements Area{
    public void area(){
        System.out.println("calculate area of circle");
    }
}
public class TestClass{

     public static void main(String []args){
        Area a = new Circle();
        a.area();
     }
}
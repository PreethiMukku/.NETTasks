class Student{
    private String name;
    private int rollno;
    public void setName(String name){
        this.name = name;
    } 
    public String getName(){
        return name;
    }
    public void setRollno(int rollno){
        this.rollno = rollno;
    } 
    public int getRollno(){
        return rollno;
    }
}
public class Test{

     public static void main(String []args){
        Student s = new Student();
        s.setName("kriti");
        s.setRollno(1275);
        System.out.println(s.getName());
        System.out.println(s.getRollno());
     }
}
import java.util.*;

class Department{

  String deptName;
  int deptId;

  Department (String deptName, int deptId) {
    this.deptName = deptName;
    this.deptId = deptId;
  }
}
class University {

  ArrayList < Department > depts = new ArrayList < Department > ();	// creating list of type department

  public void addObjects (Department obj) {
    depts.add (obj);		// Adding department type object into list
  }

  public void print () {				// printing list of departments in a university
    for (Department d:depts) {
      System.out.println ("Department name = " + d.deptName + " Id = " + d.deptId + "\n");
    }
  }

}

public class Main {

  public static void main (String[]args) {

    University u = new University ();

    Department d1 = new Department ("CSE", 101);
    Department d2 = new Department ("ECE", 102);
    Department d3 = new Department ("IT", 103);
    Department d4 = new Department ("MECH", 104);

    u.addObjects (d1);
    u.addObjects (d2);
    u.addObjects (d3);
    u.addObjects (d4);
      
    u.print ();

  }
}

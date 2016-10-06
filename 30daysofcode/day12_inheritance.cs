// HackerRank "30 Days of Code" - Day 12 - Inheritance

using System;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;

	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
	}
}

// ------[ Solution code begins here ]------------------------------------------

class Student : Person
{
    private int[] testScores;

    public Student(string firstName, string lastName, int id, int[] scores)
      : base(firstName,lastName,id)
    {
      testScores = scores;
    }

    private int AverageScore()
    {
      if(testScores.Length == 0) return 0;
      return System.Linq.Enumerable.Sum(testScores) / testScores.Length;
    }

    public char calculate()
    {
        var average = AverageScore();
        if(average >= 90) return 'O';
        if(average >= 80) return 'E';
        if(average >= 70) return 'A';
        if(average >= 55) return 'P';
        if(average >= 40) return 'D';
        return 'T';
    }
}

// ------[ Solution code ends here ]--------------------------------------------

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		}

		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.calculate() + "\n");
	}
}

using System;
class DNAReplication{   
    static string ReplicateSeqeunce(string halfDNASequence){
	string result = "";
	    foreach(char nucleotide in halfDNASequence)
	    {
    	    result += "TAGC"["ATCG".IndexOf(nucleotide)];
	    }
	        return result;
    }
    static bool IsValidSequence(string halfDNASequence){
	    foreach(char nucleotide in halfDNASequence)
	    {
    	    if(!"ATCG".Contains(nucleotide))
    	    {
        	return false;
    	    }
	    }
	        return true;
    }

   static void ASKyesnoQ(string halfSequence)
    {        
        
        Console.Write("Do you want to replicate it? (Y/N): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "Y":
                string replicatedSequence = ReplicateSeqeunce(halfSequence);
                Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                ASKyesnoQ2();
                break;

            case "N":
                ASKyesnoQ2();
                break;

            default:
                Console.WriteLine("Please input Y or N.");
                ASKyesnoQ(halfSequence);
                break;
             
        }     
    }

    static void ASKyesnoQ2()
    {
        Console.Write("Do you want to process another sequence? (Y/N): ");
        string continueChoice = Console.ReadLine();

        switch(continueChoice)
        {
            case"Y":
                Main();
            break;
            case"N":
                
            break;
            default:
                Console.WriteLine("Please input Y or N.");
                ASKyesnoQ2();
            break;
        }

    }

static void Main()
    {
        while  (true){
        Console.Write("Enter a half DNA sequence: ");
        string halfSequence = Console.ReadLine();

            if (IsValidSequence(halfSequence))
        {   
            Console.WriteLine("Current half DNA sequence: " + halfSequence);            
            ASKyesnoQ(halfSequence);
            
        }

        else if(!IsValidSequence(halfSequence))
            {               
                Console.WriteLine("That half DNA sequence is invalid.");
                ASKyesnoQ2();

            }
           break;            
        }
    }
    
}
    

 
                   


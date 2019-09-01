package corejava;

public class BinaryNumber {
	
	public int consecutiveOne(int num) {
		int remainder =0;
		int count = 0;
		int add = 1;
		//if(num >=1 && num <=10) {
			
			while(num > 0) {
				remainder = num % 2;
				num = num / 2;
				if(remainder == 1 ){
                    if(add>count){
                        count +=1;
                        
                    }
                    add++;
                    
                }else{
                    add=1;
                }      
			}
			System.out.println(count);
		
		//}
		
		return count;
	}
	
	

}

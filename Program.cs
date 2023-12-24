using System;

class Program{
  static void Main(string[] args){
  	startGame s = new startGame;
  	mainGame m = new maintGame;
	resolt r = new resolt;
  	var answer = s.startGame();
 	var num = m.mainGame(answer);
        r.resolt(num);
  }
  class startGame(){
   public int startGame(){ 
	Ramdam rand = new Ramdam();
	var maxNum = 0;
  	Console.WriteLine("数字当てゲーム開始");
	Console.Write("今回の数値の最大値を入力してください：");
  	var maxNum = Console.ReadLine();
	Console.WriteLine($"今回のゲームの数値は1から{maxNum}です。");
      	var answer = rand.Next(1,maxNum);
	return answer;
   }
}

class mainGame{
   	public int mainGame(int answer){
		var x = 0;
		var num = 0;
		while(x =! answer ){
	       		num++;
    			Console.White("回答を入力してください：");
  			x = Console.ReadLine();
    			if(x < answer){
      				Console.WriteLine($"{0}よりも大きいです。", x);
    			}else if(x > answer){
      				Console.WriteLine($"{0}よりも小さいです。", x);
    			}else{
      				Console.WriteLine("正解です！");
   			}			
		}
		return num;
	}
}

class resolt{
	public void resolt(int num){
		Console.WriteLine("今回のクリアまでの回数は{0}回です。", num);

	}
}
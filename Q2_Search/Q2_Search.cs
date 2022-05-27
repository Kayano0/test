public class Search{
    public static void Main(){
        // 昇順にソートされた配列
        var sortedArray = new int[] {1, 2, 3, 5, 12, 7890, 12345};
        // 探索対象の番号
        var targetNumber = 7890;
        // 探索実行
        var targetIndex = new Search().SearchIndex(sortedArray, targetNumber);
        // 結果出力
        System.Console.WriteLine(targetIndex);
    }

    private int SearchIndex(int[] sortedArray, int targetNumber){

        // ここから記述
	var min = 0;
	var max = sortedArray.Length - 1;

	while (min <= max) {

        var mid = min + (max - min) / 2;

        switch (targetNumber.CompareTo(sortedArray[mid])){
            case 1:  
                min = mid + 1;
                break;
            case -1: 
                max = mid - 1;
                break;
            case 0:
                return mid;
        }
	}


        // ここまで記述

        // 探索対象がない場合、-1を返す
        return -1;
    }
}
public class Search{
    public static void Main(){
        // �����Ƀ\�[�g���ꂽ�z��
        var sortedArray = new int[] {1, 2, 3, 5, 12, 7890, 12345};
        // �T���Ώۂ̔ԍ�
        var targetNumber = 7890;
        // �T�����s
        var targetIndex = new Search().SearchIndex(sortedArray, targetNumber);
        // ���ʏo��
        System.Console.WriteLine(targetIndex);
    }

    private int SearchIndex(int[] sortedArray, int targetNumber){

        // ��������L�q
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


        // �����܂ŋL�q

        // �T���Ώۂ��Ȃ��ꍇ�A-1��Ԃ�
        return -1;
    }
}
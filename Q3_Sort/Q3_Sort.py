def main():
    #�����_���ɕ��ׂ�ꂽ�d���̂Ȃ������̔z��
	array = [5, 4, 6, 2, 1, 9, 8, 3, 7, 10]
    # �\�[�g���s
	sortedArray = sort(array)
    # ���ʏo��
	[print(i) for i in sortedArray]

def sort(array):
    # �v�f����̏ꍇ�̓\�[�g�̕K�v���Ȃ��̂ŁA���̂܂ܕԋp
    if len(array) == 1:
        return array

    # �z��̐擪����l�Ƃ���
    pivot = array[0]

    # ��������L�q
    left = []
    right = []

    count = 0

    for i in array:
        if i < pivot:
            left.append(i)
        elif i > pivot:
            right.append(i)
        else:
            count += 1

    left = sort(left)
    right = sort(right)

    return left + [pivot] * count + right

    # �����܂ŋL�q

if __name__ == '__main__':
	main()
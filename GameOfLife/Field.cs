
using System.Collections;

public class Field
{
	private int width;//����Ŀ���
	private int height;//����ĸ߶�
	private Cell[,] field;
	
	public Field(int width, int height) {
		this.width = width;
		this.height = height;
		field = new Cell[height,width];
	}
	
	public int getWidth() { return width; }
	public int getHeight() { return height; }
	
	//�������е�row�е�col�з���һ��cell
	public Cell place(int row, int col, Cell o) {
		Cell ret = field[row,col];
		field[row,col] = o;
		return ret;
	}
	
	//����һ��cell
	public Cell get(int row, int col) {
		return field[row,col];
	}
	
	//���ذ�����row��,��col��ϸ������Χ������ϸ������
	public Cell[] getNeighbour(int row, int col) {
        ArrayList list = new ArrayList();
		for ( int i=-1; i<2; i++ ) {
			for ( int j=-1; j<2; j++ ) {
				int r = row+i;
				int c = col+j;
				if ( r >-1 && r<height && c>-1 && c<width && !(r== row && c == col) ) {
					list.Add(field[r,c]);
				}
			}
		}
        Cell[] cell= new Cell [list.Count];
        int flag = 0;
        foreach(object x in list)
        {
            cell[flag] = x as Cell;
            flag++;
        }
        return cell;
	}
	
	//�������
	public void clear() {
		for ( int i=0; i<height; i++ ) {
			for ( int j=0; j<width; j++ ) {
				field[i,j] = null;
			}
		}
	}
}
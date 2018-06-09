package main;

import java.util.ArrayList;

public class Field
{
	private int width;//网格的宽度
	private int height;//网格的高度
	private Cell[][] field;
	
	public Field(int width, int height) {
		this.width = width;
		this.height = height;
		field = new Cell[height][width];
	}
	
	public int getWidth() { return width; }
	public int getHeight() { return height; }
	
	//在网格中第row行第col列放置一个cell
	public Cell place(int row, int col, Cell o) {
		Cell ret = field[row][col];
		field[row][col] = o;
		return ret;
	}
	
	//返回一个cell
	public Cell get(int row, int col) {
		return field[row][col];
	}
	
	//返回包含第row行,第col列细胞的周围的所有细胞数组
	public Cell[] getNeighbour(int row, int col) {
		ArrayList<Cell> list = new ArrayList<Cell>();
		for ( int i=-1; i<2; i++ ) {
			for ( int j=-1; j<2; j++ ) {
				int r = row+i;
				int c = col+j;
				if ( r >-1 && r<height && c>-1 && c<width && !(r== row && c == col) ) {
					list.add(field[r][c]);
				}
			}
		}
		return list.toArray(new Cell[list.size()]);
	}
	
	//清空网格
	public void clear() {
		for ( int i=0; i<height; i++ ) {
			for ( int j=0; j<width; j++ ) {
				field[i][j] = null;
			}
		}
	}
}

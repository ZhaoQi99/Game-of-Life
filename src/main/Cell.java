package main;

public class Cell
{
	private boolean alive = false;
	
	public void die() { alive = false; }
	public void reborn() { alive = true; }
	public boolean isAlive() { return alive; }
}

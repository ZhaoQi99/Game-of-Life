
public class Cell
{
	private bool alive = false;//ϸ��״̬

	public void die() { alive = false; }
	public void reborn() { alive = true; }
	public bool isAlive() { return alive; }
}

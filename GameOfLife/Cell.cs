
public class Cell
{
	private bool alive = false;//ϸ��״̬
    public bool Alive { get { return alive; }set { alive = value; } }

	public void die() { alive = false; }
	public void reborn() { alive = true; }
	public bool isAlive() { return alive; }
}

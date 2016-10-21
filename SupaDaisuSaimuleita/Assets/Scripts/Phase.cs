using UnityEngine;
using System.Collections;

public abstract class Phase : MonoBehaviour
{
    public delegate void PhaseEnd(Phase me);
	public PhaseEnd ePhaseEnd;

	public abstract void BeginPhase ();

    private void EndPhase()
	{
		ePhaseEnd (this);
	}
}

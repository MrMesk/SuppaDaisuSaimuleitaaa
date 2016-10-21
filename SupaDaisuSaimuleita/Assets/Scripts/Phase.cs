using UnityEngine;
using System.Collections;

public abstract class Phase 
{
	delegate void PhaseEnd();
	PhaseEnd ePhaseEnd;

	public abstract void BeginPhase ();

	void EndPhase()
	{
		ePhaseEnd ();
	}
}

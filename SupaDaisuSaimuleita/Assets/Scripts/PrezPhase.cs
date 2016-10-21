using UnityEngine;
using System.Collections;

public class PrezPhase : Phase 
{
	public override void BeginPhase ()
	{
        EndPhase();
        StartCoroutine(Dada());
	}

    IEnumerator Dada() {
        yield return new WaitForSeconds(5);
        EndPhase();
    }
}

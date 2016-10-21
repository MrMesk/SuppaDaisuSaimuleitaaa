using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    List<Phase> phaseQueue;

    Phase currentPhase;

    public void Start() {
        if(phaseQueue.Count > 0) {
            BeginPhase(phaseQueue[0]);
        }
    }

    public void BeginPhase(Phase phase) {
        phase.ePhaseEnd += PhaseEndedHandler;
        phase.BeginPhase();
        currentPhase = phase;
    }

    public void PhaseEndedHandler(Phase endedPhase) {
        endedPhase.ePhaseEnd -= PhaseEndedHandler;
        // Begin next phase
        BeginNextPhase();
    }

    public void BeginNextPhase() {
        // Begin next phase
        if (!phaseQueue.Contains(currentPhase))
            // Error, ended phase not in phase queue
            return;
        int index = phaseQueue.IndexOf(currentPhase);
        index %= phaseQueue.Count;
        BeginPhase(phaseQueue[index]);
    }

}

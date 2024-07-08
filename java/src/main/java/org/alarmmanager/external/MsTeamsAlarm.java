package org.alarmmanager.external;

import java.util.ArrayList;
import java.util.List;

/**
 * Raise alarms via MS Teams.
 * Note: This class is provided by an external team and thus is not allowed to be changed 
 * (Compatibility and copyright reasons)
 */
public final class MsTeamsAlarm {

    /**
     * Alarms sent, for testing
     */
    public static final List<String> teamsAlarmsSent = new ArrayList<>();


    public void sendAlarmViaTeams(String message) {
        // 🧙🏽‍♀️ talks to Teams API and sends the message... 🧙🏽‍♂️

        teamsAlarmsSent.add(message);
    }
}

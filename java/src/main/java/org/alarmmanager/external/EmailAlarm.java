package org.alarmmanager.external;

import java.util.ArrayList;
import java.util.List;

/**
 * Raise alarms via Email.
 * Note: This class is provided by an external company and thus is not allowed to be changed 
 * (Compatibility and copyright reasons)
 */
public final class EmailAlarm {

    /**
     * Alarms sent, for testing
     */
    public static final List<String> emailAlarmsSent = new ArrayList<>();


    public void sendAlarmAsEmail(String message) {
        // 📧 build an email message and send it off via the mail server... 📭

        emailAlarmsSent.add(message);
    }
}

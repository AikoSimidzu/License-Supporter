# License-Supporter
License Supporter

# PHP 7.1

Made to quickly add a licensing system to your software.

For convenience, I recommend using ![LicenseAdder](https://github.com/AikoSimidzu/License-Supporter/tree/master/LicenseAdder)

# Requests:
>For checked license:
>>GET <domain /index.php?hwid= user_HWID>
>>>Response:
>>>><dd:mm:yyyy> (In fact, the format depends only on your software and yourself)

>For add license:
>>GET <domain /drawlicense.php?hwid= HWID &p= panel_password &date= date_or_status>
>>>if the password is not correct, the page will return nothing. Otherwise "OK".

>For delete license:
>>GET <domain /drawlicense.php?hwid= HWID &p= panel_password &del=1>
>>>if the password is not correct, the page will return nothing. Otherwise "OK".

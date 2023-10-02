namespace PharmacyAPI.Helpers
{
    public static class EmailBody
    {
        public static string EmailStringBody(string email,string emailToken)
        {
            return $@"
                <!DOCTYPE html>
                <html lang='en'>
                <head>
                    <meta charset='UTF-8'>
                    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                    <title>Password Reset</title>
                    <style>
                        body {{
                            font-family: Arial, sans-serif;
                            line-height: 1.6;
                        }}
                        .container {{
                            max-width: 600px;
                            margin: auto;
                            padding: 20px;
                        }}
                        h2 {{
                            color: #333;
                        }}
                        p {{
                            color: #555;
                        }}
                        .btn {{
                            display: inline-block;
                            padding: 10px 20px;
                            background-color: #007BFF;
                            color: #fff;
                            text-decoration: none;
                            border-radius: 5px;
                            margin-top: 10px;
                        }}
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <h2>Password Reset</h2>
                        <p>You're receiving this email because you requested a password reset for your PharmacyAPP account.</p>
                        <p>Click the button below to reset your password:</p>
                        <a href='http://localhost:4200/reset?email={email}&code={emailToken}' class='btn'>Reset Password</a>
                        <p>Kind Regards,<br><br> PharamacyAPP </p>
                    </div>
                </body>
                </html>
            ";
        }
    }
}
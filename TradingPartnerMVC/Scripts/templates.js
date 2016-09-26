﻿document.write('<script id="TradingPartnerDetail-template" type="text/x-kendo-template"><script type="text/x-kendo-template" id="template">\r\n\r\n    <div class="tabstrip" id="tabs">\r\n        <ul>\r\n            <li class="k-state-active">\r\n                General Information\r\n            </li>\r\n            <li>\r\n                Customer Information\r\n            </li>\r\n            <li>\r\n                Vendor Information\r\n            </li>\r\n            <li>\r\n                File Information\r\n            </li>\r\n            <li>\r\n                FTP\r\n            </li>\r\n            <li>\r\n                Audit Trail\r\n            </li>\r\n            <li>\r\n                Other Information\r\n            </li>\r\n        </ul>\r\n        <div>\r\n            <div class="general">\r\n                <table class="table">\r\n\r\n                    <tbody>\r\n                        <tr class="success">\r\n                            <td>Customer Number</td>\r\n                            <td> #= CustomerNumber #</td>\r\n                            <td>FeedCode</td>\r\n                            <td>#= FeedID #</td>\r\n                            <td></td>\r\n                            <td></td>\r\n                        </tr>\r\n                        <tr class="danger">\r\n                            <td>Customer Name</td>\r\n                            <td>#= Customer #</td>\r\n                            <td>Customer Effective Date</td>\r\n                            <td>#= CustomerEffectiveDate #</td>\r\n                            <td>Line Of Business</td>\r\n                            <td>#= LineOfBusiness #</td>\r\n                        </tr>\r\n                        <tr class="info">\r\n                            <td>Vendor</td>\r\n                            <td>#= Vendor #</td>\r\n                            <td>Vendor Effective Date</td>\r\n                            <td>#= VendorEffectiveDate #</td>\r\n                            <td>Renewal Month</td>\r\n                            <td>#= RenewalMonth #</td>\r\n                        </tr>\r\n                        <tr class="warning">\r\n                            <td>Status</td>\r\n                            <td>#= Status #</td>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td></td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n        <div>\r\n            <div class=\'custinfo\'>\r\n                <label>Account Manager:</label>#= AccountManager #\r\n\r\n\r\n            </div>\r\n        </div>\r\n        <div>\r\n            <label>Main Vendor Contact:</label>#= MainVendorContact #\r\n            <label>Main Vendor Phone:</label>#= MainVendorPhone #\r\n        </div>\r\n        <div>\r\n            <table class="table">\r\n\r\n                <tbody>\r\n                    <tr class="success">\r\n                        <td>John</td>\r\n                        <td>Doe</td>\r\n                        <td>john@example.com</td>\r\n                    </tr>\r\n                    <tr class="danger">\r\n                        <td>Mary</td>\r\n                        <td>Moe</td>\r\n                        <td>mary@example.com</td>\r\n                    </tr>\r\n                    <tr class="info">\r\n                        <td>July</td>\r\n                        <td>Dooley</td>\r\n                        <td>july@example.com</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n</script></script>');


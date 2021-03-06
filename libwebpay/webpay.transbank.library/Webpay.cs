﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author     Allware Ltda. (http://www.allware.cl)
 * @copyright  2015 Transbank S.A. (http://www.tranbank.cl)
 * @date       May 2016
 * @license    GNU LGPL
 * @version    2.0.1
 */

namespace Webpay.Transbank.Library
{
    public class Webpay
    {

        WebpayNullify nullifyTransaction;
        WebpayNormal normalTransaction;
        WebpayMallNormal mallNormalTransaction;
        WebpayCapture captureTransaction;
        WebpayComplete completeTransaction;
        WebpayOneClick oneclickTransaction;

        Configuration configuration;

        public Webpay(Configuration param)
        {
            configuration = param;
        }

        public WebpayNormal getNormalTransaction()
        {
            if (this.normalTransaction == null)
            {
                this.normalTransaction = new WebpayNormal(this.configuration);
            }
            return this.normalTransaction;
        }

        public WebpayMallNormal getMallNormalTransaction()
        {
            if (this.mallNormalTransaction == null)
            {
                this.mallNormalTransaction = new WebpayMallNormal(this.configuration);
            }
            return this.mallNormalTransaction;
        }

        public WebpayNullify getNullifyTransaction()
        {
            if (this.nullifyTransaction == null)
            {
                this.nullifyTransaction = new WebpayNullify(this.configuration);
            }
            return this.nullifyTransaction;
        }

        public WebpayCapture getCaptureTransaction()
        {
            if (this.captureTransaction == null)
            {
                this.captureTransaction = new WebpayCapture(this.configuration);
            }
            return this.captureTransaction;
        }

        public WebpayComplete getCompleteTransaction()
        {
            if (this.completeTransaction == null)
            {
                this.completeTransaction = new WebpayComplete(this.configuration);
            }
            return this.completeTransaction;
        }

        public WebpayOneClick getOneClickTransaction()
        {
            if (this.oneclickTransaction == null)
            {
                this.oneclickTransaction = new WebpayOneClick(this.configuration);
            }
            return this.oneclickTransaction;
        }

    }
}

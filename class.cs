public class Department
        {
            private int id;
            private string name;
            private string description;
            
            public Department()
            {
                Department a = new Department();
                a.setId(1);
                a.setName("Service");
                a.setDesc("To ensure customer satisfaction");

                Department b = new Department();
                b.setId(2);
                b.setName("IT");
                b.setDesc("To develop products");

                Department c = new Department();
                c.setId(3);
                c.setName("Production");
                c.setDesc("To produce products");
            }

            public void setId( int a )
            {
                id = a;
            }

            public void setName(string a)
            {
                name = a;
            }

            public void setDesc(string a)
            {
                description = a;
            }
        }

        public class Agent
        {
            private string name;
            private bool isAvailableInLiveChat;
            private int deptId;

            public Agent()
            {
                Agent a = new Agent();

            }
        }
PGDMP                  	    |            Normalization    16.0    16.0 )    *           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            +           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ,           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            -           1262    41405    Normalization    DATABASE     �   CREATE DATABASE "Normalization" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "Normalization";
                postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
                pg_database_owner    false            .           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                   pg_database_owner    false    4            �            1259    41407 
   Attributes    TABLE     �   CREATE TABLE public."Attributes" (
    id_attribute integer NOT NULL,
    attribute_name character varying NOT NULL,
    variant integer NOT NULL
);
     DROP TABLE public."Attributes";
       public         heap    postgres    false    4            �            1259    41406    Attributes_id_attribute_seq    SEQUENCE     �   ALTER TABLE public."Attributes" ALTER COLUMN id_attribute ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Attributes_id_attribute_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    216    4            �            1259    41412    KeyAttributes    TABLE     |   CREATE TABLE public."KeyAttributes" (
    fd integer NOT NULL,
    k_name integer NOT NULL,
    variant integer NOT NULL
);
 #   DROP TABLE public."KeyAttributes";
       public         heap    postgres    false    4            �            1259    41424    NotKeyAttributes    TABLE     �   CREATE TABLE public."NotKeyAttributes" (
    fd integer NOT NULL,
    nk_name integer NOT NULL,
    variant integer NOT NULL
);
 &   DROP TABLE public."NotKeyAttributes";
       public         heap    postgres    false    4            �            1259    59435    Variants    TABLE     a   CREATE TABLE public."Variants" (
    id integer NOT NULL,
    name character varying NOT NULL
);
    DROP TABLE public."Variants";
       public         heap    postgres    false    4            �            1259    67652    keys    VIEW     �   CREATE VIEW public.keys AS
 SELECT ka.fd,
    a.attribute_name
   FROM (public."KeyAttributes" ka
     JOIN public."Attributes" a ON ((ka.k_name = a.id_attribute)))
  WHERE (ka.variant = 1);
    DROP VIEW public.keys;
       public          postgres    false    217    217    217    216    216    4            �            1259    67660    not_keys    VIEW     �   CREATE VIEW public.not_keys AS
 SELECT nka.fd,
    a.attribute_name
   FROM (public."NotKeyAttributes" nka
     JOIN public."Attributes" a ON ((nka.nk_name = a.id_attribute)))
  WHERE (nka.variant = 1);
    DROP VIEW public.not_keys;
       public          postgres    false    218    216    216    218    218    4            �            1259    67664    combined_view    VIEW     �   CREATE VIEW public.combined_view AS
 SELECT k.fd,
    k.attribute_name AS key_attribute,
    n.attribute_name AS not_key_attribute
   FROM (public.keys k
     LEFT JOIN public.not_keys n ON ((k.fd = n.fd)))
  ORDER BY k.fd;
     DROP VIEW public.combined_view;
       public          postgres    false    225    227    225    227    4            �            1259    67648    fd    VIEW     �   CREATE VIEW public.fd AS
 SELECT ka.fd,
    a.attribute_name
   FROM (public."KeyAttributes" ka
     JOIN public."Attributes" a ON (((ka.k_name = a.id_attribute) AND (ka.variant = a.variant))));
    DROP VIEW public.fd;
       public          postgres    false    216    217    217    217    216    216    4            �            1259    67656    notkeys    VIEW     �   CREATE VIEW public.notkeys AS
 SELECT nka.fd,
    a.attribute_name
   FROM (public."NotKeyAttributes" nka
     JOIN public."Attributes" a ON (((nka.nk_name = a.id_attribute) AND (nka.variant = a.variant))))
  WHERE (nka.variant = 2);
    DROP VIEW public.notkeys;
       public          postgres    false    218    216    218    216    216    218    4            �            1259    67629    roles    TABLE     \   CREATE TABLE public.roles (
    id integer NOT NULL,
    name character varying NOT NULL
);
    DROP TABLE public.roles;
       public         heap    postgres    false    4            �            1259    67646    roles_id_seq    SEQUENCE     �   ALTER TABLE public.roles ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.roles_id_seq
    START WITH 4
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    222    4            �            1259    59485    users    TABLE     �   CREATE TABLE public.users (
    login character varying NOT NULL,
    password character varying NOT NULL,
    fio character varying NOT NULL,
    role integer
);
    DROP TABLE public.users;
       public         heap    postgres    false    4            �            1259    59434    variants_id_seq    SEQUENCE     �   CREATE SEQUENCE public.variants_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.variants_id_seq;
       public          postgres    false    220    4            /           0    0    variants_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.variants_id_seq OWNED BY public."Variants".id;
          public          postgres    false    219            z           2604    59441    Variants id    DEFAULT     l   ALTER TABLE ONLY public."Variants" ALTER COLUMN id SET DEFAULT nextval('public.variants_id_seq'::regclass);
 <   ALTER TABLE public."Variants" ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    220    219    220                       0    41407 
   Attributes 
   TABLE DATA           M   COPY public."Attributes" (id_attribute, attribute_name, variant) FROM stdin;
    public          postgres    false    216   '/       !          0    41412    KeyAttributes 
   TABLE DATA           >   COPY public."KeyAttributes" (fd, k_name, variant) FROM stdin;
    public          postgres    false    217   p0       "          0    41424    NotKeyAttributes 
   TABLE DATA           B   COPY public."NotKeyAttributes" (fd, nk_name, variant) FROM stdin;
    public          postgres    false    218   �0       $          0    59435    Variants 
   TABLE DATA           .   COPY public."Variants" (id, name) FROM stdin;
    public          postgres    false    220   E1       &          0    67629    roles 
   TABLE DATA           )   COPY public.roles (id, name) FROM stdin;
    public          postgres    false    222   �1       %          0    59485    users 
   TABLE DATA           ;   COPY public.users (login, password, fio, role) FROM stdin;
    public          postgres    false    221   2       0           0    0    Attributes_id_attribute_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public."Attributes_id_attribute_seq"', 25, true);
          public          postgres    false    215            1           0    0    roles_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.roles_id_seq', 4, true);
          public          postgres    false    223            2           0    0    variants_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.variants_id_seq', 4, true);
          public          postgres    false    219            |           2606    59459    Attributes attributes_pk 
   CONSTRAINT     k   ALTER TABLE ONLY public."Attributes"
    ADD CONSTRAINT attributes_pk PRIMARY KEY (id_attribute, variant);
 D   ALTER TABLE ONLY public."Attributes" DROP CONSTRAINT attributes_pk;
       public            postgres    false    216    216            ~           2606    59452    KeyAttributes keyattributes_pk 
   CONSTRAINT     o   ALTER TABLE ONLY public."KeyAttributes"
    ADD CONSTRAINT keyattributes_pk PRIMARY KEY (fd, k_name, variant);
 J   ALTER TABLE ONLY public."KeyAttributes" DROP CONSTRAINT keyattributes_pk;
       public            postgres    false    217    217    217            �           2606    59466 $   NotKeyAttributes notkeyattributes_pk 
   CONSTRAINT     v   ALTER TABLE ONLY public."NotKeyAttributes"
    ADD CONSTRAINT notkeyattributes_pk PRIMARY KEY (fd, nk_name, variant);
 P   ALTER TABLE ONLY public."NotKeyAttributes" DROP CONSTRAINT notkeyattributes_pk;
       public            postgres    false    218    218    218            �           2606    67635    roles roles_pk 
   CONSTRAINT     L   ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_pk PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.roles DROP CONSTRAINT roles_pk;
       public            postgres    false    222            �           2606    67627    users users_pk 
   CONSTRAINT     O   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pk PRIMARY KEY (login);
 8   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pk;
       public            postgres    false    221            �           2606    59445    Variants variants_pk 
   CONSTRAINT     T   ALTER TABLE ONLY public."Variants"
    ADD CONSTRAINT variants_pk PRIMARY KEY (id);
 @   ALTER TABLE ONLY public."Variants" DROP CONSTRAINT variants_pk;
       public            postgres    false    220            �           2606    59446    Attributes attributes_fk    FK CONSTRAINT     ~   ALTER TABLE ONLY public."Attributes"
    ADD CONSTRAINT attributes_fk FOREIGN KEY (variant) REFERENCES public."Variants"(id);
 D   ALTER TABLE ONLY public."Attributes" DROP CONSTRAINT attributes_fk;
       public          postgres    false    4738    216    220            �           2606    59460    KeyAttributes keyattributes_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public."KeyAttributes"
    ADD CONSTRAINT keyattributes_fk FOREIGN KEY (k_name, variant) REFERENCES public."Attributes"(id_attribute, variant);
 J   ALTER TABLE ONLY public."KeyAttributes" DROP CONSTRAINT keyattributes_fk;
       public          postgres    false    216    216    217    4732    217            �           2606    59467 $   NotKeyAttributes notkeyattributes_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public."NotKeyAttributes"
    ADD CONSTRAINT notkeyattributes_fk FOREIGN KEY (nk_name, variant) REFERENCES public."Attributes"(id_attribute, variant);
 P   ALTER TABLE ONLY public."NotKeyAttributes" DROP CONSTRAINT notkeyattributes_fk;
       public          postgres    false    216    218    218    4732    216            �           2606    67641    users users_fk    FK CONSTRAINT     j   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_fk FOREIGN KEY (role) REFERENCES public.roles(id);
 8   ALTER TABLE ONLY public.users DROP CONSTRAINT users_fk;
       public          postgres    false    4742    222    221                9  x��R�J�@<o�"/`p����<	^��%�RED���x�1ic��W�}���6	�D�!?;3���$Z�D.R��╠6c�J;����"����
��P���@�1�R@;�II_*�#�_f&}�D�˂lD����\��6�$��--k�6��ɴ��rx�La�Os��d�u-杹H$L�(=J�����#�s͝X`E�oa�����TҬ�~æ]���҆Ё�@xd��]j׼ikj�tȨ[�&�l���=i!G����E����?����Ȍۂ�)�d�/;�L~����@�.oFW�w��y��Ź�8�/�q�      !   8   x�%��  �P�ɲ^����`&��a�Jb�i�?l����xrTOu����g�	i      "   }   x�5��1�j{�\D���.��\���j�52j�hr���ț<䇬��<�%_�l	ן��	��	�����C≞艞<���P�R-�R-��.��v�v�v�幅��c���X~�?&}_s���*      $   O   x�3�0�¾�M�.l���¶;��@B�.l�� �a7��ta�1�	����rM8�j6]��v�TC�\1z\\\ �U3^      &   Q   x���	�0�s�Am�bb�z��5�0�#�Û6�prSx(�ٕ���V��K��r���4[���2����}=Y1d      %   �   x�%�=
�@��z�)r��^.�=l��.�� i�T�be��fo��������j^��|��x�8p��b���]
�����y_^O^+�<äiclZ���/e�(�����.!n�����*�| �A1�     